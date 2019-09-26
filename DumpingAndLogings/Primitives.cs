using System;

namespace Desharp.Tests.DumpingAndLogings {
	class Primitives {
		public Int16 AA = -1;
		public UInt16 AB = 2;
		public Int32 AC = -3;
		public UInt32 AD = 4;
		public Int64 AE = -5;
		public UInt64 AF = 6;
		public IntPtr AG = new IntPtr(-7);
		public UIntPtr AH = new UIntPtr(8);
		
		public float AI = -9.5E+10F;
		public double AJ = -10.5E+10;
		public decimal AK = -11.5E+10M;
		
		public char AL = '@';
		public string AM = "Hi";
		
		public bool AN = true;
		public byte AO = 0x40;		// @
		public sbyte AP = -0x25;		// %



		public Int16? BA = -10;
		public UInt16? BB = 20;
		public Int32? BC = -30;
		public UInt32? BD = 40;
		public Int64? BE = -50;
		public UInt64? BF = 60;
		public IntPtr? BG = new IntPtr(-70);
		public UIntPtr? BH = new UIntPtr(80);

		public float? BI = -90.5E+10F;
		public double? BJ = -100.5E+10;
		public decimal? BK = -101.5E+10M;

		public char? BL = '@';
		//public string? BK = '@';

		public bool? BN = true;
		public byte? BO = 0x25;		// %
		public sbyte? BP = -0x40;	// @



		public Int16? CA = null;
		public UInt16? CB = null;
		public Int32? CC = null;
		public UInt32? CD = null;
		public Int64? CE = null;
		public UInt64? CF = null;
		public IntPtr? CG = null;
		public UIntPtr? CH = null;

		public float? CI = null;
		public double? CJ = null;
		public decimal? CK = null;

		public char? CL = null;
		//public string? CK = null;

		public bool? CN = null;
		public byte? CO = null;		// %
		public sbyte? CP = null;	// @

		public void DumpAndLogLocals (Desharp.Level logLevel) {
			Int16 aa = -1;
			UInt16 ab = 2;
			Int32 ac = -3;
			UInt32 ad = 4;
			Int64 ae = -5;
			UInt64 af = 6;
			IntPtr ag = new IntPtr(-7);
			UIntPtr ah = new UIntPtr(8);
		
			float ai = -9.5E+10F;
			double aj = -10.5E+10;
			decimal ak = -11.5E+10M;
		
			char al = '@';
			string am = "Hi";
		
			bool an = true;
			byte ao = 0x40;		// @
			sbyte ap = -0x25;	// %
			Desharp.Debug.Dump(
				aa, ab, ac, ad, ae, af, ag, ah, ai, aj, ak, al, am, an, ao, ap
			);
			Desharp.Debug.Log(aa, logLevel);
			Desharp.Debug.Log(ab, logLevel);
			Desharp.Debug.Log(ac, logLevel);
			Desharp.Debug.Log(ad, logLevel);
			Desharp.Debug.Log(ae, logLevel);
			Desharp.Debug.Log(af, logLevel);
			Desharp.Debug.Log(ag, logLevel);
			Desharp.Debug.Log(ah, logLevel);
			Desharp.Debug.Log(ai, logLevel);
			Desharp.Debug.Log(aj, logLevel);
			Desharp.Debug.Log(ak, logLevel);
			Desharp.Debug.Log(al, logLevel);
			Desharp.Debug.Log(am, logLevel);
			Desharp.Debug.Log(an, logLevel);
			Desharp.Debug.Log(ao, logLevel);
			Desharp.Debug.Log(ap, logLevel);


			Int16? ba = -10;
			UInt16? bb = 20;
			Int32? bc = -30;
			UInt32? bd = 40;
			Int64? be = -50;
			UInt64? bf = 60;
			IntPtr? bg = new IntPtr(-70);
			UIntPtr? bh = new UIntPtr(80);

			float? bi = -90.5E+10F;
			double? bj = -100.5E+10;
			decimal? bk = -101.5E+10M;

			char? bl = '@';
			//string? bm = '@';

			bool? bn = true;
			byte? bo = 0x25;	// %
			sbyte? bp = -0x40;	// @
			Desharp.Debug.Dump(
				ba, bb, bc, bd, be, bf, bg, bh, bi, bj, bk, bl, /*bm,*/ bn, bo, bp
			);
			Desharp.Debug.Log(ba, logLevel);
			Desharp.Debug.Log(bb, logLevel);
			Desharp.Debug.Log(bc, logLevel);
			Desharp.Debug.Log(bd, logLevel);
			Desharp.Debug.Log(be, logLevel);
			Desharp.Debug.Log(bf, logLevel);
			Desharp.Debug.Log(bg, logLevel);
			Desharp.Debug.Log(bh, logLevel);
			Desharp.Debug.Log(bi, logLevel);
			Desharp.Debug.Log(bj, logLevel);
			Desharp.Debug.Log(bk, logLevel);
			Desharp.Debug.Log(bl, logLevel);
			//Desharp.Debug.Log(bm, logLevel);
			Desharp.Debug.Log(bn, logLevel);
			Desharp.Debug.Log(bo, logLevel);
			Desharp.Debug.Log(bp, logLevel);

			Int16? ca = null;
			UInt16? cb = null;
			Int32? cc = null;
			UInt32? cd = null;
			Int64? ce = null;
			UInt64? cf = null;
			IntPtr? cg = null;
			UIntPtr? ch = null;

			float? ci = null;
			double? cj = null;
			decimal? ck = null;

			char? cl = null;
			//string? cm = null;

			bool? cn = null;
			byte? co = null;	// %
			sbyte? cp = null;   // @
			Desharp.Debug.Dump(
				ca, cb, cc, cd, ce, cf, cg, ch, ci, cj, ck, cl, /*cm,*/ cn, co, cp
			);
			Desharp.Debug.Log(ca, logLevel);
			Desharp.Debug.Log(cb, logLevel);
			Desharp.Debug.Log(cc, logLevel);
			Desharp.Debug.Log(cd, logLevel);
			Desharp.Debug.Log(ce, logLevel);
			Desharp.Debug.Log(cf, logLevel);
			Desharp.Debug.Log(cg, logLevel);
			Desharp.Debug.Log(ch, logLevel);
			Desharp.Debug.Log(ci, logLevel);
			Desharp.Debug.Log(cj, logLevel);
			Desharp.Debug.Log(ck, logLevel);
			Desharp.Debug.Log(cl, logLevel);
			//Desharp.Debug.Log(cm, logLevel);
			Desharp.Debug.Log(cn, logLevel);
			Desharp.Debug.Log(co, logLevel);
			Desharp.Debug.Log(cp, logLevel);
		}
	}
}
