
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

    //TODO: lasten updateeminen esim tänne
    public virtual void Update()
    {
      if (gameObject.children != null)
      {
        foreach (var child in gameObject.children)
        {
          child.behavior.Update();
        }
      }
    }
  }
}
