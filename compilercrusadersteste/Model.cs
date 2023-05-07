﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compilercrusadersteste
{
    class Model
    {

        public delegate void Model_event(object sender, EventArgs e);
        public event Model_event Pesquisa_Concluida;
        public event Model_event Ficheiro_Gerado;
        private View view;
        public Model(View v)
        {
            view = v;
        }

        public void Pesquisa(string negocio,string local, string motor_busca)  
        {
            /// Coisas a acontecer
            /// 
            /// conclui e publica informação

            Pesquisa_Concluida(this, EventArgs.Empty);
   


    }

        public void GerarFicheiroResultados()  // gerar ficheiro final
        {
            Console.WriteLine("Model: olha eu a fazer um ficheiro com cenas ");
            Ficheiro_Gerado(this, EventArgs.Empty);

            
        }



       
        // evento ficheiro gerado
    }
}
