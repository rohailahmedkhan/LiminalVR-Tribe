private Renderer _renderer;
void Start(){
    _renderer=gameObject.Component<Renderer>();
}
public void OnEnter(){
    _renderer.material.color=Color.red;
}
public void OnExit(){
    _renderer.material.color=Color.white;

}
public void OnGrab(){
    Transform ptrtransform=GvrPointerInputModule.Pointer.PointerTransform;
    transform.SetParent(pointerTransform,true);
}
public void OnRelease(){
    transform.SetParent(null,true);
}