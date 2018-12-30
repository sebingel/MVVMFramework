namespace MVVMFramework.Model
{
    internal sealed class PocoVehicle
    {
        public PocoVehicle(string marke, string typ, int kilowatt)
        {
            Marke = marke;
            Typ = typ;
            Kilowatt = kilowatt;
        }

        public string Marke { get; set; }
        public string Typ { get; set; }
        public int Kilowatt { get; set; }
    }
}
