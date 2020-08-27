import {Stack} from "./stack/stack";
import {StackArray} from "./stack/stack-array";

console.log('hello world');

let s:Stack<number>= new StackArray<number>();

s.push(1);
console.log(s.peek());