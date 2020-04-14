using System;

public class Karyawan
{
	public int NIK { get; set; }
	public string Nama { get; set; }
	public int GajiBulanan { get; set; }


	public Karyawan(int NIK, string Nama, float GajiBulanan)
	{
		this.NIK = NIK;
		this.Nama = Nama;
		this.GajiBulanan = GajiBulanan;
	}

}
