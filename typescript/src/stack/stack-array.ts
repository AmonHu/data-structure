import {Stack} from "./stack";

export class StackArray<T> implements Stack<T> {
    private _list: Array<T>;

    constructor() {
        this._list = [];
    }

    pop(): T | undefined {
        return this._list.pop();
    }

    push(e: T) {
        this._list.push(e);
    }

    isEmpty(): boolean {
        return this._list.length === 0;
    }

    size(): number {
        return this._list.length;
    }

    peek(): T {
        return this._list[this._list.length - 1];
    }

    clear(): void {
        this._list = [];
    }
}