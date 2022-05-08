import {
  Divider,
  Grid,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableRow,
  Typography,
} from "@mui/material";
import axios from "axios";
// import { error } from "console";
import { useEffect, useState } from "react";
import { error } from "console";
import agent from "../../app/api/agent";
import NotFound from "../../app/errors/NotFound";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { useParams } from "react-router-dom";
import { Blog } from "../../app/models/blog";

export default function ProductDetails() {
  const { id } = useParams<{ id: string }>();
  const [blog, setBlog] = useState<Blog | null>(null);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    agent.Blog.details(parseInt(id))
      .then((response) => setBlog(response))
      .catch((error) => console.log(error.response))
      .finally(() => setLoading(false));
  }, [id]);

  if (loading) return <LoadingComponent message="Loading blog..." />;
  if (!blog) return <NotFound />;

  return (
    <Grid container spacing={6}>
      <Grid item xs={6}>
        <img
          src={blog.pictureUrl}
          alt={blog.blogName}
          style={{ width: "100%" }}
        />
      </Grid>
      <Grid item xs={6}>
        <Typography variant="h3">{blog.blogName}</Typography>
        <Divider sx={{ mb: 2 }} />
        {/* <Typography variant="h4" color="secondary">
          ${(blog.price / 100).toFixed(2)}
        </Typography> */}
        <TableContainer>
          <Table>
            <TableBody>
              <TableRow>
                <TableCell>Title</TableCell>
                <TableCell>{blog.blogName}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Description</TableCell>
                <TableCell>{blog.description}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Data</TableCell>
                <TableCell>{blog.dataArtikullit}</TableCell>
              </TableRow>
              {/* <TableRow>
                <TableCell>Content</TableCell>
                <TableCell>{blog.blog}</TableCell>
              </TableRow>
              <TableRow>
                <TableCell>Quantity in stock</TableCell>
                <TableCell>{blog.quantityInStock}</TableCell>
              </TableRow> */}
            </TableBody>
          </Table>
        </TableContainer>
      </Grid>
    </Grid>
  );
}
