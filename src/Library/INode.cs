namespace Library;

public interface INode<H>
{
    void accept(IVisitor<H> visitor);
}