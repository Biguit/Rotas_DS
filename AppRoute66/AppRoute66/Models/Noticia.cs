using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute66.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia>TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
                new Noticia
                {
                NoticiaId=1,
                Categoria="Esportes",
                Titulo="O time da escola vence dos catados",
                Conteudo="O time da escola vence por 10x2 de time montado com os alunos sem time",
                Data=new DateTime(22/03/2020)
                },

                new Noticia
                {
                NoticiaId=2,
                Categoria="Esportes",
                Titulo="Ônibus da seleção masculina preso em blitz",
                Conteudo="O ônibus da seleção foi parado pela blitz por alguns motivos: Sem Volante. Sem Lateral. Grandes problemas na frente. E ainda transportando todo tipo de droga, menos craque",
                Data=new DateTime(01/05/2020)
                },

                new Noticia
                {
                NoticiaId=3,
                Categoria="Escola",
                Titulo="Custo da Escola",
                Conteudo="Pai vai reclamar do boleto de pagamento da escola do Joãozinho. Se ele é o que menos estuda na turma, a mensalidade tem que ser menor!",
                Data=new DateTime(10/04/2020)
                },

                new Noticia
                {
                NoticiaId=4,
                Categoria="Escola",
                Titulo="Diário de Uma Nerd",
                Conteudo="Hoje deu mei primeiro beijo! Tudo aconteceu quando eu estava de bobeira, andando na rua e quando olho mais a frente, lá está ele, o cara mais popular da escola. " +
                "Fomos nos aproximando, e ele sorriu pra mim... Foi nesse momento que tudo aconteceu: Fiquei tão emocionada que esqueci de olhar pro chão, tropecei e... Beijei o chão.",
                Data=new DateTime(10/02/2020)
                }
            };
            return retorno;
        }

    }
}