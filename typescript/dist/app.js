"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const stack_array_1 = require("./stack/stack-array");
console.log('hello world');
let s = new stack_array_1.StackArray();
s.push(1);
console.log(s.peek());
