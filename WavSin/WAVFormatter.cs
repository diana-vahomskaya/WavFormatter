using System;
using System.IO;
using System.Runtime.InteropServices;

namespace WavSin
{
    public class WAVFormatter
    {
		[StructLayout(LayoutKind.Sequential)]
		// Структура, описывающая заголовок WAV файла.
		internal class WAVHeader
		{
			// WAV-формат начинается с RIFF-заголовка:

			// Содержит символы "RIFF" в ASCII кодировке
			public UInt32 ChunkId = 0x46464952;

			// 36 + subchunk2Size, или более точно:
			// 4 + (8 + subchunk1Size) + (8 + subchunk2Size)
			// Это оставшийся размер цепочки, начиная с этой позиции.
			// Иначе говоря, это размер файла - 8, то есть,
			// исключены поля chunkId и chunkSize.
			public UInt32 ChunkSize;

			// Содержит символы "WAVE"
			public UInt32 Format = 0x45564157;

			// Формат "WAVE" состоит из двух подцепочек: "fmt " и "data":
			// Подцепочка "fmt " описывает формат звуковых данных:

			// Содержит символы "fmt "
			public UInt32 Subchunk1Id = 0x20746d66;

			// Это оставшийся размер подцепочки, начиная с этой позиции.
			public UInt32 Subchunk1Size = 16;

			// Аудио формат, полный список можно получить здесь http://audiocoding.ru/wav_formats.txt
			public UInt16 AudioFormat = 1;

			// Количество каналов. Моно = 1, Стерео = 2 и т.д.
			public UInt16 NumChannels = 1;

			// Частота дискретизации. 8000 Гц, 44100 Гц и т.д.
			public UInt32 SampleRate;

			// sampleRate * numChannels * bitsPerSample/8
			public UInt32 ByteRate;

			// numChannels * bitsPerSample/8
			// Количество байт для одного сэмпла, включая все каналы.
			public UInt16 BlockAlign;

			// Так называемая "глубиная" или точность звучания. 8 бит, 16 бит и т.д.
			public UInt16 BitsPerSample;

			// Подцепочка "data" содержит аудио-данные и их размер.

			// Содержит символы "data"
			public UInt32 Subchunk2Id = 0x61746164;

			// numSamples * numChannels * bitsPerSample/8
			// Количество байт в области данных.
			public UInt32 Subchunk2Size;

			// Далее следуют непосредственно Wav данные.
			public byte[] GetBytes()
            {
				int size = Marshal.SizeOf(this);
				byte[] arr = new byte[size];
				IntPtr ptr = Marshal.AllocHGlobal(size);
				Marshal.StructureToPtr(this, ptr, true);
				Marshal.Copy(ptr, arr, 0, size);
				Marshal.FreeHGlobal(ptr);
				return arr;
            }
		}
		public static void SignalToFile(string filename, double[] signal, ushort samplerate, ushort bps)
		{
			var head = new WAVHeader
			{
				SampleRate = samplerate,
				BitsPerSample = bps,
				BlockAlign = (ushort)(1 * bps / 8),
				ByteRate = (ushort)(1 * samplerate * bps / 8),
				Subchunk2Size = (uint)(signal.Length * 1 * bps / 8),
				ChunkSize = (uint)(36 + signal.Length * 1 * bps / 8),
			};

			byte[] data = new byte[head.Subchunk2Size];
			switch (bps)
            {
				case 8:
					for (int i = 0; i < signal.Length; i++) {
						data[i] = (byte)(Math.Abs(signal[i]) * 127);
						if (signal[i] < 0) {
							data[i] += 128;
                        }
                    }
					break;
				case 16:
					for (int i = 0; i < signal.Length; i++)
                    {
						short val = (short)(signal[i] * short.MaxValue);
						data[2 * i] = (byte)(val % 256);
						data[2 * i + 1] = (byte)(val / 256);
                    }
					break;
				case 32:
					for (int i = 0; i < signal.Length; i++)
                    {
						int val = (int)(signal[i] * int.MaxValue);
						data[4 * i] = (byte)(val % 256);
						val /= 256;
						data[4 * i + 1] = (byte)(val % 256);
						val /= 256;
						data[4 * i + 2] = (byte)(val % 256);
						val /= 256;
						data[4 * i + 3] = (byte)(val % 256);
                    }
					break;
				default: throw new NotImplementedException();
            }

			using (BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Create, FileAccess.Write)))
            {
				bw.Write(head.GetBytes());
				bw.Write(data);
            }
		}
	}
	
}
