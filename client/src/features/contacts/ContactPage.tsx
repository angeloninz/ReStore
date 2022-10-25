import { Button, ButtonGroup } from "@mui/material";
import Typography from "@mui/material/Typography";
//import { useDispatch, useSelector } from "react-redux"; //redux implementation
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { decrement, increment } from "./counterSlice";
/*import {
  CounterState,
  decrement,
  DECREMENT_COUNTER,
  increment,
  INCREMENT_COUNTER,
} from "./counterReducer";*/ //redux implementation

export default function ContactPage() {
  //redux implementation
  //const dispatch = useDispatch();
  //const { data, title } = useSelector((state: CounterState) => state);

  //redux-toolkit implementation
  const dispatch = useAppDispatch();
  const { data, title } = useAppSelector((state) => state.counter);

  return (
    <>
      <Typography variant="h2">{title}</Typography>
      <Typography variant="h5">The data is: {data}</Typography>
      <ButtonGroup>
        <Button
          onClick={() => dispatch(decrement(1))}
          variant="contained"
          color="error"
        >
          Decrement
        </Button>
        <Button
          onClick={() => dispatch(increment(1))}
          variant="contained"
          color="primary"
        >
          Increment
        </Button>
        <Button
          onClick={() => dispatch(increment(5))}
          variant="contained"
          color="secondary"
        >
          Increment by 5
        </Button>
      </ButtonGroup>
    </>
  );
}
