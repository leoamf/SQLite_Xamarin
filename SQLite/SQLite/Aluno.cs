using System;
namespace SQLite
{
    [Table("Aluno")]
    public class Aluno
    {
        [PrimaryKey,AutoIncrement, Column("id")]
        public int Id { get; set; } 

        [Column("nome")]
        public string Nome { get; set; }

        [Column("idade")]
        public string Idade { get; set; }
    }
}
