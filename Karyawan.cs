using System;

public class Karyawan
{
	public int NIK { get; set; }
	public string Nama { get; set; }
	public float GajiBulanan { get; set; }

	public Karyawan(int NIK, string Nama, float GajiBulanan)
	{
		this.NIK = NIK;
		this.Nama = Nama;
		this.GajiBulanan = GajiBulanan;
	}

	public void InfoGaji()
	{

	}
}
