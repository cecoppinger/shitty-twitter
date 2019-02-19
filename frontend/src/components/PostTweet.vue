<template>
  <div class="container">
    <h3 class="justify-content-center alert alert-danger">Make your own Shitty Tweet!</h3>
    <form>
      <div class="form-group row justify-content-center">
        <label for="message" class="col-md-2 col-form-label">Body</label>
        <div class="col-md-6">
          <textarea id="message" class="form-control" placeholder="Shitty Tweet Here" v-model="newShittyTweet.message" />
        </div>  
      </div>
      <div class="form-group row justify-content-center">
        <label for="author" class="col-md-2 col-form-label ">Author</label>
        <div class="col-md-6">
          <input id="author" class="form-control" placeholder="Your Name Here" v-model="newShittyTweet.author" />
        </div>
      </div>
      <div style="text-align: center;">
        <button class="btn btn-danger" type="button" @click="postTweet()">Post!</button>
      </div>
    </form> 
  </div>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  name: 'PostTweet',
  data() {
    return {
      newShittyTweet: {
        message: '',
        author: '',
      },
    };
  },
  methods: {
    ...mapActions(['postShittyTweet']),
    postTweet() {
      this.postShittyTweet(this.newShittyTweet);
      this.$router.push('/all');
    },
  },
};
</script>

<style scoped>
label {
  color: white;
}
h3 {
  text-align: center;
}
</style>
