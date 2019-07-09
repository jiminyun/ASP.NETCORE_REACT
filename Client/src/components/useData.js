import { useState, useEffect, useReducer } from "react";
import axios from "axios";

export const studentReducer = (state, action) => {
  switch (action.type) {
    case "FETCH_INIT":
      return { ...state, isLoading: true, isError: false };
    case "FETCH_SUCCESS":
      return {
        ...state,
        isLoading: false,
        isError: false,
        data: action.payload
      };

    case "FETCH_FAILURE":
      return { ...state, isLoading: false, isError: true };
    case "ADD_TAG":
      return { ...state, data: action.payload };
    default:
      throw new Error();
  }
};

//Data fetch
export const useDataApi = (initialUrl, initialData) => {
  const [url, setUrl] = useState(initialUrl);
  const [state, dispatch] = useReducer(studentReducer, {
    isLoading: false,
    isError: false,
    data: initialData
  });

  useEffect(() => {
    let didCancel = false;
    const fetchData = async () => {
      try {
        const res = await axios(url);

        const _students = res.data.students.map(student => {
          student.tag = [];
          return student;
        });

        const students = { students: _students };

        if (!didCancel) dispatch({ type: "FETCH_SUCCESS", payload: students });
      } catch (err) {
        if (!didCancel) dispatch({ type: "FETCH_FAILURE" });
      }
    };
    fetchData();

    return () => {
      didCancel = true;
    };
  }, [state]);

  const doFetch = url => {
    setUrl(url);
  };
  return { ...state, doFetch };
};
