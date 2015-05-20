﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapParse.Exceptions
{
	public class MalformedPolyException : Exception
	{
		public MalformedPolyException() { }
		public MalformedPolyException(string message)
			: base(message)
		{
		}
		public MalformedPolyException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
