module prelude

[<Measure>]
type m

[<Measure>]
type s

[<Measure>]
type kg

type Vector2< [<Measure>] 'm> = { x:float<'m>; y:float<'m> }
with
  static member Diag (k:float<'m>) : Vector2<'m> = { x=k; y=k }
  static member (~-) (v:Vector2<'m>) : Vector2<'m> = { x= -v.x; y= -v.y }
  static member (+) (v1:Vector2<'m>, v2:Vector2<'m>) : Vector2<'m> = { x=v1.x+v2.x; y=v1.y+v2.y }
  static member (+) (v1:Vector2<'m>, k:float<'m>) : Vector2<'m> = v1 + Vector2.Diag k
  static member (-) (v1:Vector2<'m>, v2:Vector2<'m>) : Vector2<'m> = v1 + (-v2)
  static member (*) (v1:Vector2<'m>, v2:Vector2<'n>) : Vector2<'m * 'n> = { x=v1.x*v2.x; y=v1.y*v2.y }
  static member (*) (v1:Vector2<'m>, k:float<'n>) : Vector2<'m * 'n> = v1 * Vector2.Diag k
  static member (/) (v1:Vector2<'m>, v2:Vector2<'n>) : Vector2<'m / 'n> = { x=v1.x/v2.x; y=v1.y/v2.y }
  static member (/) (v1:Vector2<'m>, k:float<'n>) : Vector2<'m / 'n> = v1 / Vector2.Diag k
  member v.Length : float<'m> = sqrt(v.x * v.x + v.y * v.y)
