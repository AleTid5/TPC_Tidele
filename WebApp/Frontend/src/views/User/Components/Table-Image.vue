<template>
    <div class="card shadow bg-dark">
        <div class="card-header border-0 bg-transparent">
            <div class="row align-items-center">
                <div class="col">
                    <h3 class="mb-0 text-white">
                        {{title}}
                    </h3>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-4">
                <div class="table-responsive mt-9">
                    <table class="table align-items-center table-flush">
                        <thead>
                        <tr>
                            <th>Nombre</th>
                            <th>{{ curImage.Name }}</th>
                        </tr>
                        <tr>
                            <th>Rating</th>
                            <th><rating @change="$emit('change')"
                                        :rating="curImage.Rating"
                                        :mediaId="curImage.Id"></rating></th>
                        </tr>
                        <tr>
                            <th>Genero</th>
                            <th>{{ curImage.Gender.Name }}</th>
                        </tr>
                        <tr>
                            <th>Categoria</th>
                            <th>{{ curImage.Category.Name }}</th>
                        </tr>
                        <tr>
                            <th>Veces vista</th>
                            <th>{{ curImage.ReproducedTimes }}</th>
                        </tr>
                        </thead>
                    </table>
                </div>
            </div>
            <div class="col-8">
                <div class="row">
                    <div class="col-2">
                        <base-button type="success" icon="ni ni-bold-left"
                                     style="margin-top: 35vh;"
                                     @click="prev()"
                                     :rounded="true" class="float-right"></base-button>
                    </div>
                    <div class="col-8">
                        <siema ref="siema" class="siema"
                               :current.sync="curSlide" auto-play
                               @init="init" @change="change"
                               :ready="true">
                            <div class="slide text-center" v-for="image in images">
                                <img :src="image.Source" style="min-height: 550px;max-height: 550px">
                            </div>
                        </siema>
                    </div>
                    <div class="col-2">
                        <base-button type="success" icon="ni ni-bold-right"
                                     style="margin-top: 35vh;"
                                     @click="next()"
                                     :rounded="true" class="float-left"></base-button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</template>
<script>
    import api from "@/api";
    import Vue from 'vue';
    import Siema from 'vue2-siema';
    import rating from "./Rating";

    Vue.use(Siema);

    export default {
        name: 'table-image',
        components: {
            rating
        },
        props: {
            type: {
                type: String
            },
            title: String,
            data: Array
        },
        beforeUpdate() {
            this.images.map(image => this.files[image.Id] = true, this);
        },
        computed: {
            images() {
                return this.data;
            },
            getImages() {
                return this.files;
            }
        },
        data() {
            return {
                files: {},
                curSlide: 0,
                curImage: {}
            }
        },
        methods: {
            async onPlay(image) {
                image.ReproducedTimes++;
                await api.mediaAddReproducedTime({mediaId: image.Id});
            },

            init() {
                this.curImage = this.images[0];
                this.onPlay(this.curImage);
            },

            change() {
                this.curImage = this.images[this.curSlide];
                this.onPlay(this.curImage);
            },

            prev() {
                this.$refs.siema.prev();
            },

            next() {
                this.$refs.siema.next();
            },
        },

        watch: {
            images() {
                this.init();
            }
        }
    }
</script>
<style scoped>
    >>> .rounded-circle {
        height: 50px;
        width: 50px;
    }

    >>> .btn.rounded-circle > i {
        line-height: 25px;
        margin-left: -2px;
    }
</style>
