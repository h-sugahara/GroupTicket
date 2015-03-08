

public class MyKiiInitializeBehaviour : KiiInitializeBehaviour
{
	public override void Awake ()
	{
		base.Awake ();
		// KiiCloudSDK has been initialized.
		// You can call KiiCloud APIs.
	}
}