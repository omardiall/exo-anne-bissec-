namespace space AnneesBissextiles{
	
	 public class calendriergregorien
{
	public static bool estbissextile(ushort annee) {


		if (annee == 0) { throw new ArgumentOutOfRangeException("annee"); }



		if (annee % 400 == 0)
		{
			return true;
		}
		else if (annee % 100 == 0)
		{
			return false;
		}
		else if (annee % 4 == 0)
		{
			return true;
		}
		else
		{
			return ;

		}


	}




}


}