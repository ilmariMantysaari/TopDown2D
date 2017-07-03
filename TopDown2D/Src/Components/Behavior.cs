
namespace TopDown2D
{
  /// <summary>
  /// Handles the behaviour of the gameobject, for example movement, controls etc
  /// </summary>
  public class Behavior
  {
    public GameObject gameObject;

    public Behavior(GameObject parent)
    {
      this.gameObject = parent;
    }

    public virtual void Update()
    {

    }
  }
}
