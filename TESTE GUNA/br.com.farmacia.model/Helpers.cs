﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTE_GUNA.br.com.farmacia.model
{
    public class Helpers
    {
        public void LimparTela(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                //limpar o campo da tela
                                (ctr2 as TextBox).Text = string.Empty;
                            }
                            if (ctr2 is MaskedTextBox)
                            {
                                //limpar o campo da tela
                                (ctr2 as MaskedTextBox).Text = string.Empty;
                            }
                        }
                    }
                }
            }

        }
    }

}