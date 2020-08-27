"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.StackMap = void 0;
class StackMap {
    constructor() {
        this._count = 0;
        this._items = new Map();
    }
    pop() {
        let e = this._items.get(this._count);
        this._items.delete(this._count);
        this._count--;
        return e;
    }
    push(e) {
        this._items.set(this._count++, e);
    }
    peek() {
        return this._items.get(this._count);
    }
    isEmpty() {
        return this._count === 0;
    }
    clear() {
        this._items.clear();
    }
    size() {
        return this._count;
    }
}
exports.StackMap = StackMap;
