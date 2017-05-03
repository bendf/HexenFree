namespace HexenFree

open UnityEngine
 
type SimpleScript() = 
    inherit MonoBehaviour()
    member this.Start() = Debug.Log("Hello from F#")
