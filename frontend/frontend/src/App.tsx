import React, { useEffect, useState } from "react";
import "./App.css";
import Header from "./Header";
import BowlerTable from "./Bowlers/BowlerList";

function App() {
  return (
    <div className="App">
      <Header />
      <BowlerTable />
    </div>
  );
}

export default App;
