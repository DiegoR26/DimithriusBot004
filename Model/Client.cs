
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
        public bool MunicipalTaxes { get; private set; }
        public bool StateTaxes { get; private set; }

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
