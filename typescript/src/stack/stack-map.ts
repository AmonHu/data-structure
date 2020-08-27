import {Stack} from "./stack";

export class StackMap<T> implements Stack<T> {
    private _items: Map<number, T>;
    private _count: number = 0;

    constructor() {
        this._items = new Map<number, T>();
    }

    pop(): T | undefined {
        let e = this._items.get(this._count);
        this._items.delete(this._count);
        this._count--;
        return e;
    }

    push(e: T): void {
        this._items.set(this._count++, e);
    }

    peek(): T | undefined {
        return this._items.get(this._count);
    }

    isEmpty(): boolean {
        return this._count === 0;
    }

    clear(): void{
        this._items.clear();
    }

    size(): number{
        return this._count;
    }

}