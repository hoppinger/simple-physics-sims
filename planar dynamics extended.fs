module planar_dynamics_extended

open prelude

// a horizontal force of 10N is applied for 5s to a body of mass 5kg
// at the same time, a vertical force of 5N is applied
// then, a horizontal force of -2N is applied for 2s

let p0 = { x=0.0<m>; y=0.0<m> }
let m = 5.0<kg>
let F1 = { x=10.0<N>; y=5.0<N> }
let a1 = F1 / m
let dt1 = 5.0<s>
let p1 = p0 + a1 * dt1 * dt1

let F2 = { x= -2.0<N>; y=0.0<N> }
let a2 = F2 / m
let dt2 = 2.0<s>
let p2 = p1 + a2 * dt2 * dt2

