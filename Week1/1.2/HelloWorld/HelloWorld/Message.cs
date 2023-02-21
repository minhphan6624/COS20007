using System;

namespace HelloWorld
{
	public class Message
	{
		private string _text;

		public Message(string atext)
		{
			_text = atext;
		}

		public void Print()
		{
			Console.WriteLine(_text);
		}

	}
}

