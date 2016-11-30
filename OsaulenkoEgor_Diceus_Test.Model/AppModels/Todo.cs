using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsaulenkoEgor_Diceus_Test.Model.AppModels
{
    /// <summary>
    /// Todo model.
    /// </summary>
    [Serializable()]
    public class Todo
    {
        /// <summary>
        /// Id of Todo instance.
        /// </summary>
        //public int IdTodo { get; set; }
        /// <summary>
        /// Time of instance creation.
        /// </summary>
        public DateTime TimeCreated { get; set; }
        /// <summary>
        /// Time for execution task.
        /// </summary>
        public DateTime TimeExecute { get; set; }
        /// <summary>
        /// Title of the task.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Description of the task.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Activity state.
        /// </summary>
        public bool Active { get; set; }
    }
}
