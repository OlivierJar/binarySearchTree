
type Branch = Tree option// Branch can be a tree or Null
and Tree ={left:Branch;value:float;right:Branch}    // and, so it can refear to branch