using System;

namespace Desharp.Tests.DumpingAndLogings {
	class Arrays {
		
		public Int16[]		AA = new Int16[] { 1, -1 };
		public UInt16[]		AB = new UInt16[] { 2, 22 };
		public Int32[]		AC = new Int32[] { -3, 3 };
		public UInt32[]		AD = new UInt32[] { 4, 44 };
		public Int64[]		AE = new Int64[] { -5, 5 };
		public UInt64[]		AF = new UInt64[] { 6, 66 };
		public IntPtr[]		AG = new IntPtr[] { new IntPtr(-7), new IntPtr(7) };
		public UIntPtr[]	AH = new UIntPtr[] { new UIntPtr(8), new UIntPtr(88) };

		public float[]		AI = new float[] { -9.5E+10F, 9.5E+10F };
		public double[]		AJ = new double[] { -10.5E+10, 10.5E+10 };
		public decimal[]	AK = new decimal[] { -11.5E+10M, 11.5E+10M };

		public char[]		AL = new char[] { '@', '#' };
		public string[]		AM = new string[] { "Hi", "how", "are", "you?" };

		public bool[]		AN = new bool[] { true, false };
		public byte[]		AO = new byte[] { 0x40, 0x23 };		// @, #
		public sbyte[]		AP = new sbyte[] { -0x25, -0x24 };	// %, $



		public Int16?[]		BA = new Int16?[] { null, 1, -1 };
		public UInt16?[]	BB = new UInt16?[] { 2, null, 22 };
		public Int32?[]		BC = new Int32?[] { -3, 3, null };
		public UInt32?[]	BD = new UInt32?[] { null, 4, 44 };
		public Int64?[]		BE = new Int64?[] { -5, null, 5 };
		public UInt64?[]	BF = new UInt64?[] { 6, 66, null };
		public IntPtr?[]	BG = new IntPtr?[] { null, new IntPtr(-7), new IntPtr(7) };
		public UIntPtr?[]	BH = new UIntPtr?[] { new UIntPtr(8), null, new UIntPtr(88) };

		public float?[]		BI = new float?[] { -9.5E+10F, 9.5E+10F, null };
		public double?[]	BJ = new double?[] { null, -10.5E+10, 10.5E+10 };
		public decimal?[]	BK = new decimal?[] { -11.5E+10M, null, 11.5E+10M };

		public char?[]		BL = new char?[] { '@', '#', null };
		public string[]		BM = new string[] { "Hi", null, "are", "you?" };

		public bool?[]		BN = new bool?[] { true, false, null };
		public byte?[]		BO = new byte?[] { 0x40, null, 0x23 };		// @, #
		public sbyte?[]		BP = new sbyte?[] { null, -0x25, 0x24 };	// %, $
		


		public static int[][] JaggedArr = new int[][] {
			new int[]{1, 2, 3},
			new int[]{10, 20, 30}
		};
		public static int?[][] JaggedArrNullable = new int?[][] {
			new int?[]{1, 2, 3},
			new int?[]{10, 20, 30}
		};


		
		public void DumpAndLogLocals (Desharp.Level logLevel) {
			
			Int16[]		aa = new Int16[] { 1, -1 };
			UInt16[]	ab = new UInt16[] { 2, 22 };
			Int32[]		ac = new Int32[] { -3, 3 };
			UInt32[]	ad = new UInt32[] { 4, 44 };
			Int64[]		ae = new Int64[] { -5, 5 };
			UInt64[]	af = new UInt64[] { 6, 66 };
			IntPtr[]	ag = new IntPtr[] { new IntPtr(-7), new IntPtr(7) };
			UIntPtr[]	ah = new UIntPtr[] { new UIntPtr(8), new UIntPtr(88) };

			float[]		ai = new float[] { -9.5E+10F, 9.5E+10F };
			double[]	aj = new double[] { -10.5E+10, 10.5E+10 };
			decimal[]	ak = new decimal[] { -11.5E+10M, 11.5E+10M };

			char[]		al = new char[] { '@', '#' };
			string[]	am = new string[] { "Hi", "how", "are", "you?" };

			bool[]		an = new bool[] { true, false };
			byte[]		ao = new byte[] { 0x40, 0x23 };		// @, #
			sbyte[]		ap = new sbyte[] { -0x25, -0x24 };  // %, $
			
			int[][] aJaggedArr = new int[][] {
				new int[]{1, 2, 3},
				new int[]{10, 20, 30}
			};
			Desharp.Debug.Dump(
				aa, ab, ac, ad, ae, af, ag, ah, ai, aj, ak, al, am, an, ao, ap, aJaggedArr
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
			Desharp.Debug.Log(aJaggedArr, logLevel);
			
			
			
			Int16?[]	ba = new Int16?[] { null, 1, -1 };
			UInt16?[]	bb = new UInt16?[] { 2, null, 22 };
			Int32?[]	bc = new Int32?[] { -3, 3, null };
			UInt32?[]	bd = new UInt32?[] { null, 4, 44 };
			Int64?[]	be = new Int64?[] { -5, null, 5 };
			UInt64?[]	bf = new UInt64?[] { 6, 66, null };
			IntPtr?[]	bg = new IntPtr?[] { null, new IntPtr(-7), new IntPtr(7) };
			UIntPtr?[]	bh = new UIntPtr?[] { new UIntPtr(8), null, new UIntPtr(88) };

			float?[]	bi = new float?[] { -9.5E+10F, 9.5E+10F, null };
			double?[]	bj = new double?[] { null, -10.5E+10, 10.5E+10 };
			decimal?[]	bk = new decimal?[] { -11.5E+10M, null, 11.5E+10M };

			char?[]		bl = new char?[] { '@', '#', null };
			string[]	bm = new string[] { "Hi", null, "are", "you?" };

			bool?[]		bn = new bool?[] { true, false, null };
			byte?[]		bo = new byte?[] { 0x40, null, 0x23 };		// @, #
			sbyte?[]	bp = new sbyte?[] { null, -0x25, 0x24 };	// %, $
			
			int?[][] bJaggedArrNullable = new int?[][] {
				new int?[]{1, 2, 3, null},
				new int?[]{10, 20, null, 30}
			};
			Desharp.Debug.Dump(
				ba, bb, bc, bd, be, bf, bg, bh, bi, bj, bk, bl, bm, bn, bo, bp, bJaggedArrNullable
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
			Desharp.Debug.Log(bm, logLevel);
			Desharp.Debug.Log(bn, logLevel);
			Desharp.Debug.Log(bo, logLevel);
			Desharp.Debug.Log(bp, logLevel);
			Desharp.Debug.Log(bJaggedArrNullable, logLevel);
			
		}
	}
}
