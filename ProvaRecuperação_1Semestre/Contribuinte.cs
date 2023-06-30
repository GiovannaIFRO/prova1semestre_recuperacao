public class Contribuinte
{
    public string nome;
    public string cpf;
    public int idade;
    public int tempo_carreira;
    public string profissao;
    public string sexo;
    public int calculo;

    public string get()
    {
        return nome;
    }
    public void set(string nome)
    {
        this.nome = nome;
    }

    public string get2()
    {
        return cpf;
    }
    public void set2(string cpf)
    {
        this.cpf = cpf;
    }

    public int get3()
    {
        return idade;
    }
    public void set3(int idade)
    {
        this.idade = idade;
    }

    public int get4()
    {
        return tempo_carreira;
    }
    public void set4(int tempo_carreira)
    {
        this.tempo_carreira = tempo_carreira;
    }

    public string get5()
    {
        return profissao;
    }
    public void set5(string profissao)
    {
        this.profissao = profissao;
    }

    public string get6()
    {
        return sexo;
    }
    public void set6(string sexo)
    {
        this.sexo = sexo;
    }

    public int get7()
    {
        return calculo;
    }
    public void set7(int calculo)
    {
        this.calculo = calculo;
    }



    public int Aposentadoria(int idade, int tempo_carreira, string profissao, string sexo, int calculo)
    {
        int tempo = idade + tempo_carreira;

        if (sexo == "feminino")
        {
            if (profissao == "saúde")
            {
                if (tempo == 95)
                {
                    calculo = 0;
                }
                else if (tempo < 95)
                {
                    calculo = tempo - 95;
                    calculo = calculo * -1;
                }

            }

            else if (profissao == "professor")
            {
                if (tempo == 85)
                {
                    calculo = 0;
                }
                else if (tempo < 85)
                {
                    calculo = tempo - 85;
                    calculo = calculo * -1;
                }

            }

            else if (profissao == "agente de segurança")
            {
                if (tempo == 85)
                {
                    calculo = 0;
                }
                else if (tempo < 85)
                {
                    calculo = tempo - 85;
                    calculo = calculo * -1;
                }


            }
            else if (profissao == "demais serviços")
            {
                if (tempo == 95)
                {
                    calculo = 0;
                }
                else if (tempo < 95)
                {
                    calculo = tempo - 95;
                    calculo = calculo * -1;
                }

            }
        }

        else if (sexo == "masculino")
        {
            if (profissao == "saúde")
            {
                if (tempo == 105)
                {
                    calculo = 0;
                }
                else if (tempo < 105)
                {
                    calculo = tempo - 105;
                    calculo = calculo * -1;
                }
            }

            else if (profissao == "professor")
            {
                if (tempo >= 95)
                {
                    calculo = 0;
                }
                else if (tempo < 95)
                {
                    calculo = tempo - 95;
                    calculo = calculo * -1;
                }

            }

            else if (profissao == "agente de segurança")
            {
                if (tempo == 105)
                {
                    calculo = 0;
                }
                else if (tempo < 105)
                {
                    calculo = tempo - 105;
                    calculo = calculo * -1;
                }

            }
            else if (profissao == "demais serviços")
            {
                if (tempo == 105)
                {
                    calculo = 0;
                }
                else if (tempo < 105)
                {
                    calculo = tempo - 105;
                    calculo = calculo * -1;
                }

            }
        }
        return calculo;
    }
}


    
        

