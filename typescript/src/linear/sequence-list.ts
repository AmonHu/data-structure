import {LinearList} from "./linear-list";

export class SequenceList<T> implements LinearList<T> {
    private _list: Array<T> | undefined;

    constructor() {
        this._list = new Array<T>();
    }


    initList(): void {
        this._list = new Array<T>();
    }


    destroyList(): void {
        delete this._list;
    }


    clearList(): void {
        this._list = [];
    }


    isEmpty(): boolean {
        return !!this._list && this._list.length == 0;
    }


    getLength(): number {
        return !!this._list ? this._list.length : 0;
    }


    getElement(index: number): T {
        if (!this._list) {
            throw new Error('the linear list is undefined.');
        }
        return this._list[index];
    }

    findElement(e: T, compare: (a: T, b: T) => boolean): number {
        return 0;
    }
}