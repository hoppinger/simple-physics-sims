module planar_dynamics_extended

open prelude

// a body travels linearly for 10 seconds at a velocity of (3,2) m/s, and for 5 seconds at a velocity of (5,5) m/s

let p0 = { x=0.0<m>; y=0.0<m> }
let v1 = { x=3.0<m/s>; y=2.0<m/s> }
let dt1 = 10.0<s>
let p1 = p0 + v1 * dt1

let v2 = { x=5.0<m/s>; y=5.0<m/s> }
let dt2 = 5.0<s>
let p2 = p1 + v2 * dt2

