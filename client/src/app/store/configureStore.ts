import { configureStore } from "@reduxjs/toolkit";
import { TypedUseSelectorHook, useDispatch, useSelector } from "react-redux";
import { basketSlice } from "../../features/basket/basketSlice";
import { catalogSlice } from "../../features/catalog/catalogSlice";
//import { createStore } from "redux"; //redux implementation
//import counterReducer from "../../features/contacts/counterReducer"; //redux implementation
import { counterSlice } from "../../features/contacts/counterSlice";

//redux implementation
//export function configureStore() {
//  return createStore(counterReducer);
//}

//redux-toolkit implementation
export const store = configureStore({
  reducer: {
    counter: counterSlice.reducer,
    basket: basketSlice.reducer,
    catalog: catalogSlice.reducer,
  },
});

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;

export const useAppDispatch = () => useDispatch<AppDispatch>();
export const useAppSelector: TypedUseSelectorHook<RootState> = useSelector;
