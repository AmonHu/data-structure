"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.StackArray = void 0;
class StackArray {
    constructor() {
        this._list = [];
    }
    pop() {
        return this._list.pop();
    }
    push(e) {
        this._list.push(e);
    }
    isEmpty() {
        return this._list.length === 0;
    }
    size() {
        return this._list.length;
    }
    peek() {
        return this._list[this._list.length - 1];
    }
    clear() {
        this._list = [];
    }
}
exports.StackArray = StackArray;
