﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lin_sniffer
{
	public class LinMessageService : ILinMessageService
	{
		public void PrintIncomintMessage(byte[] messageArray)
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("<- {0}", BitConverter.ToString(messageArray));
		}
	}
}
