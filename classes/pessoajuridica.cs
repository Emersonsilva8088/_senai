namespace _senai.classes
{
    public class Pessoajuridica : Pessoa
    {
        public string? cnpj {get; set;}
        public void Inserir (Pessoajuridica pj) {
            using (StreamWriter sw = new StreamWriter(pj.Nome+".txt"))
            {
                sw.WriteLine($"{pj.Nome},{pj.Rendimento},{pj.cnpj}");
            }

        }

    }
}