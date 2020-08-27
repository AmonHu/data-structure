"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.SequenceList = void 0;
class SequenceList {
    constructor() {
        this._list = new Array();
    }
    initList() {
        this._list = new Array();
    }
    destroyList() {
        delete this._list;
    }
    clearList() {
        this._list = [];
    }
    isEmpty() {
        return !!this._list && this._list.length == 0;
    }
    getLength() {
        return !!this._list ? this._list.length : 0;
    }
    getElement(index) {
        if (!this._list) {
            throw new Error('the linear list is undefined.');
        }
        return this._list[index];
    }
    findElement(e, compare) {
        return 0;
    }
}
exports.SequenceList = SequenceList;
