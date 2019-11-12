using System;

public class Produto
{
    public String nome;
    public int quantidade;
    public float valor;

    public Produto()
    {
        this.nome = "";
        this.quantidade = 0;
        this.valor = 0;
    }

    public Produto(String nome, int quantidade, float valor)
	{
        this.nome = nome;
        this.quantidade = quantidade;
        this.valor = valor;        
	}

    public void AdcionarProduto(String nome, int quantidade, float valor) {
        Produto p = new Produto(nome, quantidade, valor);
    }

    public void ListarTodos()
    {
        Produto p;
    }

    public override string ToString()
    {
        return "Produto "+this.nome;
        //return base.ToString();
    }

}


