
using Model.Enums;

namespace Model
{
    public class Client
    {
        public int Id { get; private set; }
        public string? SistCod { get; private set; }
        public string Name { get; private set; }
        public string CNPJ { get; private set; }
        public int Branch { get; private set; }
        public ECity City { get; private set; }
        public ECountry Country { get; private set; }
        public string? MunicipalRegister { get; private set; }
        public string? StateRegister { get; private set; }
        public string? MunicipalLogin { get; private set; }
        public string? MunicipalPassword { get; private set; }
        public bool Active { get; private set; }
        public ETaxation Taxation { get; private set; }


        public Client(string? sistCod, string name, string cNPJ, int branch, ECity city, ECountry country, string? municipalRegister, string? stateRegister, string? municipalLogin, string? municipalPassword, bool active, ETaxation taxation)
        {
            SistCod = sistCod;
            Name = name;
            CNPJ = cNPJ;
            Branch = branch;
            City = city;
            Country = country;
            MunicipalRegister = municipalRegister;
            StateRegister = stateRegister;
            MunicipalLogin = municipalLogin;
            MunicipalPassword = municipalPassword;
            Active = active;
            Taxation = taxation;

        }

        public Client(int id, string? sistCod, string name, string cNPJ, int branch, ECity city, ECountry country, string? municipalRegister, string? stateRegister, string? municipalLogin, string? municipalPassword, bool active, ETaxation taxation, bool municipalTaxes, bool stateTaxes)
        {
            Id = id;
            SistCod = sistCod;
            Name = name;
            CNPJ = cNPJ;
            Branch = branch;
            City = city;
            Country = country;
            MunicipalRegister = municipalRegister;
            StateRegister = stateRegister;
            MunicipalLogin = municipalLogin;
            MunicipalPassword = municipalPassword;
            Active = active;
            Taxation = taxation;

        }

        public string GetSituationStatus()
        {
            if (Active)
            {
                return "Ativa";
            }
            else
            {
                return "Inativa";
            }
        }
    }
}
