import { Button, Divider, Paper, Typography } from "@mui/material";
import { Container } from "@mui/system";
//import { useEffect } from "react";
import { useLocation, useNavigate } from "react-router-dom";

export default function ServerError() {
  //const history = useHistory();
  const navigate = useNavigate();
  const { state }: any = useLocation();

  //useEffect(() => {
  //  console.log(state);
  //}, [state]);

  return (
    <Container component={Paper}>
      {state?.error ? (
        <>
          <Typography variant="h3" color="error" gutterBottom>
            {state.error.title}
          </Typography>
          <Divider />
          <Typography>
            {state.error.detail || "Internal Server Error"}
          </Typography>
        </>
      ) : (
        <Typography variant="h5" gutterBottom>
          Server Error
        </Typography>
      )}
      <Button onClick={() => navigate("/catalog")}>Go back to the store</Button>
    </Container>
  );
}
