namespace Library; 

public class MayorEdad: IVisitor<Person>
{
    private int Mayor = 0;
    public void Visit (Node<Person> node) 
    {
        if (node.Content.Edad > Mayor)
        {
            this.Mayor = node.Content.Edad;
        }
        foreach (Node<Person> item in node.Children)
        {
            item.accept(this);
        }
    }

    public int Older (Node<Person> node) 
    {
        node.accept(this);
        return this.Mayor;
    }
}