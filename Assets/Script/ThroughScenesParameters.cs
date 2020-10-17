public static class ThroughScenesParameters {
	private static string sceneToLoad = null;

	public static void setSceneToLoad(int stl) {
		sceneToLoad = ""+stl;
	}

	public static int getSceneToLoad() {
		if (sceneToLoad != null) {
			return int.Parse(sceneToLoad);
		}
		return -1;
	}
}
