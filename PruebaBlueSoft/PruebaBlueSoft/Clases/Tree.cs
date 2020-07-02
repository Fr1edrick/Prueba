namespace PruebaBlueSoft
{
  public class Tree
  {
    private int _leaves = 100;

    public int leaves
    {
      get
      {
        return _leaves;
      }
      set
      {
        _leaves = value;
      }
      
    }

    public Tree doubleTreeLeaves(Tree tree1)
    {
      tree1 = new Tree();
      tree1.leaves = 2 * tree1.leaves;
      return tree1;
    }
  }
}
