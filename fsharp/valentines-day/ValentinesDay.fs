module ValentinesDay

// TODO: please define the 'Approval' discriminated union type
type Approval =
    | Yes
    | No
    | Maybe
// TODO: please define the 'Cuisine' discriminated union type
type Cuisine =
    | Korean
    | Turkish
// TODO: please define the 'Genre' discriminated union type
type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller
// TODO: please define the 'Activity' discriminated union type
type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity) : Approval =
    match activity with
    | BoardGame | Chill -> Approval.No
    | Movie m when m = Genre.Romance -> Approval.Yes
    | Movie m -> Approval.No
    | Restaurant r when r = Cuisine.Korean -> Approval.Yes
    | Restaurant r -> Approval.Maybe
    | Walk w when w < 3 -> Approval.Yes
    | Walk w when w < 5 -> Approval.Maybe
    | Walk w -> Approval.No
