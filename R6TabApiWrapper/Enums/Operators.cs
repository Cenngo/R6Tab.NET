using System;
using System.Collections.Generic;
using System.Text;

namespace R6Api.Enums
{
	public class Operators
	{
		private Operators(string value) { Value = value; }
		public string  Value { get; set; }

		public static Operators Smoke { get { return new Operators("2:1"); } }
		public static Operators Castle { get { return new Operators("2:2"); } }
		public static Operators Doc { get { return new Operators("2:3"); } }
		public static Operators Glaz { get { return new Operators("2:4"); } }
		public static Operators Blitz { get { return new Operators("2:5"); } }
		public static Operators Buck { get { return new Operators("2:6"); } }
		public static Operators Blackbeard { get { return new Operators("2:1"); } }
		public static Operators Capitao { get { return new Operators("2:1"); } }
		public static Operators Hibana { get { return new Operators("2:9"); } }
		public static Operators Jackal { get { return new Operators("2:A"); } }
		public static Operators Ying { get { return new Operators("2:B"); } }
		public static Operators Ela { get { return new Operators("2:C"); } }
		public static Operators Dokkaebi { get { return new Operators("2:D"); } }
		public static Operators Maestro { get { return new Operators("2:1"); } }
		public static Operators Mute { get { return new Operators("3:1"); } }
		public static Operators Ash { get { return new Operators("3:2"); } }
		public static Operators Rook { get { return new Operators("3:3"); } }
		public static Operators Fuze { get { return new Operators("3:4"); } }
		public static Operators IQ { get { return new Operators("3:5"); } }
		public static Operators Frost { get { return new Operators("3:6"); } }
		public static Operators Vakyrie { get { return new Operators("3:7"); } }
		public static Operators Caveira { get { return new Operators("3:8"); } }
		public static Operators Echo { get { return new Operators("3:9"); } }
		public static Operators Mira { get { return new Operators("3:A"); } }
		public static Operators Lesion { get { return new Operators("3:B"); } }
		public static Operators Zofia { get { return new Operators("3:C"); } }
		public static Operators Vigil { get { return new Operators("3:D"); } }
		public static Operators Lion { get { return new Operators("3:E"); } }
		public static Operators Alibi { get { return new Operators("3:F"); } }
		public static Operators Sledge { get { return new Operators("4:1"); } }
		public static Operators Pulse { get { return new Operators("4:2"); } }
		public static Operators Twitch { get { return new Operators("4:3"); } }
		public static Operators Kapkan { get { return new Operators("4:4"); } }
		public static Operators Jager { get { return new Operators("4:5"); } }
		public static Operators Finka { get { return new Operators("4:E"); } }
		public static Operators Thatcher { get { return new Operators("5:1"); } }
		public static Operators Thermite { get { return new Operators("5:2"); } }
		public static Operators Montagne { get { return new Operators("5:3"); } }
		public static Operators Tachanka { get { return new Operators("5:4"); } }
		public static Operators Bandit { get { return new Operators("5:5"); } }
		public static Operators GSG9_Recruit { get { return new Operators("1:5"); } }
		public static Operators Spetsnaz_Recruit { get { return new Operators("1:4"); } }
		public static Operators GIGN_Recruit { get { return new Operators("1:3"); } }
		public static Operators FBI_Recruit { get { return new Operators("1:2"); } }
		public static Operators SAS_Recruit { get { return new Operators("1:1"); } }
		public static Operators Nomad { get { return new Operators("2:11"); } }
		public static Operators Kaid { get { return new Operators("3:11"); } }
		public static Operators Clash { get { return new Operators("3:10"); } }
		public static Operators Maverick { get { return new Operators("2:10"); } }
		public static Operators Gridlock { get { return new Operators("2:12"); } }
		public static Operators Mozzie { get { return new Operators("3:12"); } }
	}
}
