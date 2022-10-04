using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTarefas.Models
{
    #region Tarefas
    public class Tarefa
    {
        public int TarefaId { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório inserir a mensagem")]
        [StringLength(50, ErrorMessage = "Use menos de 50 caracteres")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório inserir a data")]
        [DataType(DataType.Time)]
        public string tempo { get; set; }
        #endregion
    }
}