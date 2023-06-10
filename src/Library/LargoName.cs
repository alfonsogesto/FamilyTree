namespace Library;

public class VisitorNameLength : IVisitor<Person>
{

    private string Nombre;
    private int Length = 0;
    public void Visit (Node<Person> node) 
    {
        if (node.Content.Nombre.Length > Length)
        {
            this.Length = node.Content.Nombre.Length;
            this.Nombre = node.Content.Nombre;
        }
        foreach (Node<Person> item in node.Children)  
        {
            item.accept(this);
        }
    }

    public string NameLength (Node<Person> node) 
    {
        node.accept(this);
        return this.Nombre;
    }
}