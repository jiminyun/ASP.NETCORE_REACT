import React, { Fragment, useState, useEffect } from 'react';
import axios from 'axios';
import Tour from "../Tour"
import "./tourList.scss"

const App = () => {
  const [tours, setTours] = useState([]);
  const [query, setQuery] = useState('redux');

  useEffect(() => {
    const fetchData = async () => {
      const result = await axios(
        'http://localhost:1562/api/cities/'
      );
      setTours(result.data);
    };
    
    fetchData();
  }, []);

  console.log("tours" , tours);
  return (
   <section className="tourlist">
    {tours.map(tour => ( <Tour key={tour.id} tour={tour} />))}
   </section>
  );
}

export default App;