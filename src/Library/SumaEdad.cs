namespace Library;

public class VisitorSumaEdad : IVisitor<Person>  
{
    private int suma = 0;
    public void Visit(Node<Person> node) 
    {
        this.suma += node.Content.Edad;
        
        foreach (Node<Person> item in node.Children) 
        {
            item.accept(this);
        }
    }

    public int getAgeSum(Node<Person> node) 
    {
        node.accept(this);
        return this.suma;
    }
}