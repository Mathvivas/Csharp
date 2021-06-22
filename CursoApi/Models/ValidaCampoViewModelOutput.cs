using System.Collections.Generic;

namespace CursoApi.Models
{
    public class ValidaCampoViewModelOutput
    {
        
        public IEnumerable<string> Erros { get; private set; }

        public ValidaCampoViewModelOutput(IEnumerable<string> erros) {
            
            Erros = erros;
        }
    }
}