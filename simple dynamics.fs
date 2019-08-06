module simple_dynamics

open prelude

// a body travels linearly for 10 seconds at a velocity of 5 m/s, and for 5 seconds at a velocity of 3 m/s

let p0 = 0.0<m>
let v1 = 5.0<m/s>
let dt1 = 10.0<s>
let p1 = p0 + v1 * dt1

let v2 = 3.0<m/s>
let dt2 = 5.0<s>
let p2 = p1 + v2 * dt2
