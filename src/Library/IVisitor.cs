namespace Library

{
    public interface IVisitor<H>
    {
        void Visit(Node<H> node);
        
    }
}