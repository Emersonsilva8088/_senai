namespace _senai.classes
{
    public class pessoajuridica : pessoa
    {
        public string? cnpj {get; set;}
        public void Inserir (pessoajuridica pj) {
            using (StringWriter sw = new StringWriter(pj.Nome+".txt"))
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.cnpj}");
            }

        }

    }
}