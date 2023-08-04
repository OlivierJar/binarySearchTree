type Branch =
    |Tree of Tree // Branch can be a tree or Null
    |None
and Tree ={left:Branch;value:float;right:Branch}    // and, so it can refear to branch



// Insert function will add value to the tree

let rec insert ( tree:Tree, num:float):Tree=
    match tree with
    | {left=l;value=v;right=r} ->
        if v>=num 
        then {left=Tree(insertHelp (l,num));value=v;right=r} 
        else {left=l;value=v;right=Tree(insertHelp (r,num))}

//Helper function will filter the cases where there is no more tree going out, and insert the value directly
and insertHelp (branch: Branch, num:float):Tree=
    match branch with
    |None-> {left=None;value=num;right=None}//In case of no branch, create one with no branches
    |Tree t-> insert (t, num)// If thre is branches, keep searching where the number belongs
    
