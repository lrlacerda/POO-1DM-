using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produto_Interface
{
    public interface ICarrinho
    {
        //definir (declarar) quais os métodos deveram ser implementados na classe que herdar dessa interface

        //Crud: create, Read, Update, Delete

        //Create
        void Adicionar(Produto produto);

        //Read
        void Listar();

        //Update
        void Atualizar(int codigo, Produto produto);

        //Delete
        void Remover(Produto produto);
    }
}