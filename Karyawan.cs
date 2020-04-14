using System;

public class Karyawan
{
	public int NIK { get; set; }
	public string Nama { get; set; }
	public double GajiBulanan { get; set; }


	public Karyawan(int NIK, string Nama, int GajiBulanan)
	{
		this.NIK = NIK;
		this.Nama = Nama;
		this.GajiBulanan = GajiBulanan;
		if (GajiBulanan < 0)
		{
			this.GajiBulanan = 0;
		}
		else
		{
			this.GajiBulanan = GajiBulanan;
		}
	}

}
